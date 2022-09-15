using MediatR;

using MyEcommerce.Application.UseCases.Products.CreateProduct;

namespace MyEcommerce.Api.Routes
{

    public static class ProductRoutes
    {
        const string PATH = "/Products";

        public static IEndpointRouteBuilder MapProducts(this IEndpointRouteBuilder endpoint)
        {
            endpoint.MapPost(PATH, async (IMediator mediator, CreateProductRequest request)
                => await mediator.Send(request).ToHttpResult());


            //endpoint.MapPost(PATH, async (IMediator mediator, CreateProductRequest request) =>
            //    {
            //        return await mediator.Send(request).ToHttpResult();
            //    });

            return endpoint;
        }
    }

}
