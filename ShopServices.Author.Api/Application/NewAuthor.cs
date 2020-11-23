namespace ShopServices.Author.Api.Application
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Models;
    using MediatR;
    using Persistence;

    public class NewAuthor
    {
        public class Execute : IRequest
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public DateTime? DateOfBirth { get; set; }
        }

        public class Handler : IRequestHandler<Execute>
        {
            //Refactor this
            public readonly AuthorContext authorContext;

            public Handler(AuthorContext context)
            {
                authorContext = context;
            }

            public async Task<Unit> Handle(Execute request, CancellationToken cancellationToken)
            {
                Author author = new()
                {
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    DateOfBirth = request.DateOfBirth,
                    AuthorGuid = Guid.NewGuid().ToString()
            };

                authorContext.Authors.Add(author);
                
                int result = await authorContext
                                .SaveChangesAsync(cancellationToken)
                                .ConfigureAwait(false);

                if(result > 0) return Unit.Value;

                throw new Exception("Error: Failed to save changes for author");
            }
        }
    }
}