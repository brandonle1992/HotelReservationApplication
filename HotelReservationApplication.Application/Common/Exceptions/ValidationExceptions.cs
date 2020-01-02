using System;
using System.Collections.Generic;
using System.Linq;
using FluentValidation.Results;

namespace HotelReservationApplication.Application.Common.Exceptions
{
    public class ValidationExceptions : Exception
    {
        public ValidationExceptions() : base("One or more validation failures have occured.")
        {
            Failures = new Dictionary<string, string[]>();
        }

        public ValidationExceptions(List<ValidationFailure> failures) : this()
        {
            var propertyName = failures
                .Select(e => e.PropertyName)
                .Distinct()
                .ToList();

            propertyName.ForEach(property =>
            {
                var propertyFailure = failures
                .Where(e => e.PropertyName == property)
                .Select(e => e.ErrorMessage)
                .ToArray();

                Failures.Add(property, propertyFailure);
            });
        }

        public IDictionary<string, string[]> Failures { get; }
    }
}
