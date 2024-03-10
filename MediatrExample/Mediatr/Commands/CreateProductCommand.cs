using MediatR;

namespace MediatrExample.Mediatr.Commands;

public class CreateProductCommand : IRequest<Guid>
{
    public String Name { get; set; }
    public int Quantity { get; set; }
    public Decimal Value { get; set; }

    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Guid>
    {
        public Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            //repository araciligi ile veritabanina gonderilir veya event bus ile event'e de gonderilir

            return Task.FromResult(Guid.NewGuid());
            //throw new NotImplementedException();
        }
    }
}