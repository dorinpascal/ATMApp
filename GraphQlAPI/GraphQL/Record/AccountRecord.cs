namespace GraphQlAPI.GraphQL.Record
{
    public record AccountRecord
    (
        int Id, 
        string AccountNumber,
        string Password,
        string Name,
        double Amount
    );
}