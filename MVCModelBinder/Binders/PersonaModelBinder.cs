using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCModelBinder.Models;

namespace MVCModelBinder.Binders
{
    public class PersonaModelBinder : IModelBinder
    {
        object IModelBinder.BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var request = controllerContext.HttpContext.Request;
            //OTRA FORMA DE RECUPERAR LOS DATOS
            //DEL FORMULARIO
            var raw = bindingContext.ValueProvider.GetValue("nombre");

            string nombre = request.Form.Get("nombre");
            string primerapellido = request.Form.Get("primerapellido");
            string segundoapellido = request.Form.Get("segundoapellido");
            int edad = Convert.ToInt32(request.Form.Get("edad"));
            return new Persona { NombreCompleto = nombre + primerapellido + segundoapellido, Edad = edad };

        }
    }
}