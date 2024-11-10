namespace aws_sqs.Domain.Entities
{
    public class Account
    {
        public String Id { get; set; }

        public User owner { get; set; }

        public float balance { get; set; }


    }
}
