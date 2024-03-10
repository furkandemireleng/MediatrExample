using MediatR;

namespace MediatrExample.Mediatr.Queries;

public class GetProductByIdQueryHandler: IRequestHandler<GetProductByIdQuery,GetProductByIdViewModel>
{ 
    public Task<GetProductByIdViewModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        var viewModel = new GetProductByIdViewModel()
        {
            Id = Guid.NewGuid(),
            Name = "Book"
        };
        return Task.FromResult(viewModel);
        //throw new NotImplementedException();
    }
}