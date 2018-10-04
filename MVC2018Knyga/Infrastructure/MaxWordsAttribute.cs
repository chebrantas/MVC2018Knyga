using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC2018Knyga.Infrastructure
{
    //Custom Annotation pasirasome patys jei nera standartiniu validation metodu
    public class MaxWordsAttribute : ValidationAttribute
    {
        //:base("{0} has to many words.") uzrasu pakeiciame standartini klaidos informacini uzrasa
        public MaxWordsAttribute(int maxWords):base("{0} has to many words.")
        {
            _maxWords = maxWords;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                var valueAsString = value.ToString();
                if (valueAsString.Split(' ').Length > _maxWords)
                {
                    var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                    return new ValidationResult(errorMessage);
                }
            }
            return ValidationResult.Success;
        }
        private readonly int _maxWords;
    }
}