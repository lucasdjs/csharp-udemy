namespace IWantApp.Endpoints.Producties;

public record ProductResponse(string Name, string CategoryName, string Description, decimal price, bool HasStock, bool Active);