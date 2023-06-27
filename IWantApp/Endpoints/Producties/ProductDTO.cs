namespace IWantApp.Endpoints.Producties;

public record ProductDTO(string Name, Guid CategoryId, string Description, bool HasStock, decimal Price, bool Active);
