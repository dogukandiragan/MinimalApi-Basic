using MinimalApiBasics.Models;
using MinimalApiBasics.Services;

namespace MinimalApiBasics.Endpoints
{
    public static class UserEndpoints
    {

        public static void MapCustomerEndpoints(this WebApplication app)
        {
            app.MapGet("/users", (IUserService customerService) =>
            {
                return customerService.GetAllUsers();
            });

            app.MapGet("/users/{id}", (int id, IUserService customerService) =>
            {
                var customer = customerService.GetUserById(id);
                return customer is not null ? Results.Ok(customer) : Results.NotFound();
            });

            app.MapPost("/users", (User user, IUserService customerService) =>
            {
                customerService.AddUser(user);
                return Results.Created($"/users/{user.Id}", user);
            });

            app.MapPut("/users/{id}", (int id, User user, IUserService customerService) =>
            {
                customerService.UpdateUser(id, user);
                return Results.NoContent();
            });

            app.MapDelete("/users/{id}", (int id, IUserService customerService) =>
            {
                customerService.DeleteUser(id);
                return Results.NoContent();
            });
        }


    }
}
