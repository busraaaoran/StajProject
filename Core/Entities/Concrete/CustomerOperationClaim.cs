namespace Core.Entities.Concrete
{
    public class CustomerOperationClaim: IEntity
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public int OperationClaimId { get; set; }
    }
}
