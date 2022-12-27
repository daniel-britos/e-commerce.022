using Ecommerce.Dto;
using Microsoft.AspNetCore.Components;

namespace Ecommerce.Componentes
{
    public class DatosPersonalesBase : ComponentBase
    {
        [Parameter]
        public DatosPersonalesDto? PersonalProfile { get; set; }

        [CascadingParameter]
        public string Color { get; set; }
    }
}
