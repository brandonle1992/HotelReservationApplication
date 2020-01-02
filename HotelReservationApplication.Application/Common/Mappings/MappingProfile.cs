using System;
using System.Linq;
using System.Reflection;
using AutoMapper;

namespace HotelReservationApplication.Application.Common.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            ApplyMappingsFromAssembly(Assembly.GetExecutingAssembly());
        }

        private void ApplyMappingsFromAssembly(Assembly assembly)
        {
            var types = assembly.GetExportedTypes()
                .Where(t => t.GetInterfaces().Any(i =>
                    i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IMapFrom<>)))
                .ToList();

            types.ForEach(t =>
            {
                var instance = Activator.CreateInstance(t);

                var methodInfo = t.GetMethod("Mapping") ?? t.GetInterface("IMapFrom`1").GetMethod("Mapping");

                methodInfo?.Invoke(instance, new object[] { this });
            });
        }
    }
}
