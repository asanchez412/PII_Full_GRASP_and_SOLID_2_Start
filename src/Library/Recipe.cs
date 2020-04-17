//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }   
        
        // se decidió reemplazar el método anterior con uno nuevo que almacena en una variable
        // la información que la siguiente clase necesitará para continuar trabajando
        // en este caso, imprimir.
        // se utiliza expert dado que esta clase es la experta en información y capaz de
        // otorgar toda la información necesaria

        public string GetTextToPrint()
        {
            string result = string.Empty;
            
            result = $"Receta de {this.FinalProduct.Description}" + Environment.NewLine;
            foreach (Step step in this.steps)
            {
                result = result + $"Se utilizan {step.Quantity} de {step.Input.Description} " + $"usando {step.Equipment.Description} durante {step.Time} segundos" + Environment.NewLine;
            }
            return result;
        }
    }
}