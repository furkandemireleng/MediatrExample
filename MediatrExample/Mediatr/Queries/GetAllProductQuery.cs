using MediatR;

namespace MediatrExample.Mediatr.Queries;

public class GetAllProductQuery : IRequest<List<GetProductByIdViewModel>>
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<GetProductByIdViewModel>>
    {
        public Task<List<GetProductByIdViewModel>> Handle(GetAllProductQuery request,
            CancellationToken cancellationToken)
        {
            var model = new GetProductByIdViewModel()
            {
                Id = Guid.NewGuid(),
                Name = "BOOK"
            };

            var model2 = new GetProductByIdViewModel()
            {
                Id = Guid.NewGuid(),
                Name = "CAR"
            };

            return Task.FromResult(new List<GetProductByIdViewModel>() { model, model2 });
        }
    }
}