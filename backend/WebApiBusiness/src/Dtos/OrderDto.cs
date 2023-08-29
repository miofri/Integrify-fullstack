using WebApiDomain.Entities;

namespace WebApiBusiness.Dtos;

public class OrderReadDto
{
    public List<OrderProducts> OrderProducts { get; set; }
    public Guid UserId { get; set; }
    public OrderStatus Status { get; set; }
}

public class OrderCreateDto
{
    public List<OrderProductsDto> ProductsAndAmount { get; set; } // List of product IDs
    public Guid UserId { get; set; }
    public OrderStatus Status { get; set; }
}

public class OrderUpdateDto
{
    public List<OrderProducts> OrderProducts { get; set; }
    public Guid UserId { get; set; }
}

public class OrderProductsDto
{
    public Guid ProductId { get; set; }
    public int Amount { get; set; }
}
