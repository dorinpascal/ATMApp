using System;
using GraphQlAPI.Model;

namespace GraphQlAPI.GraphQL.Record
{
    public record TransactionRecord
    (
        int id,
        string Action,
        //DateTime Date,
        double Amount,
        Account Account
    );
}