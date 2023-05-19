using Core.Entities.OrderAggregate;

namespace Core.Specification
{
    public class OrderByPaymentIntentIdSpecification : BaseSpecification<Order>
    {
        public OrderByPaymentIntentIdSpecification(string PaymentIntentId)
            : base(o => o.PaymentIntentId == PaymentIntentId)
        {
        }
    }
}