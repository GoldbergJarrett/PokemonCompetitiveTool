using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Type = CompetitiveTool.Data.Type;

namespace CompetitiveTool.Pages
{
    public partial class TypeQuizOption : ComponentBase
    {
        [Parameter]
        public Type Option { get; set; }
        [Parameter]
        public EventCallback<Type> OnClickHandler { get; set; }

        public bool IsHovered { get; set; }
        public string IsHoveredCSS 
        {
            get => IsHovered ? "background-color: lightskyblue;" : "";
        }

        public bool IsSelected { get; set; }

        public void OnMouseOver()
        {
            if(!IsSelected) IsHovered = true;
            StateHasChanged();
        }

        public void OnClick()
        {
            OnClickHandler.InvokeAsync(Option); 

            IsSelected = !IsSelected;
        }

        
    }
}
