using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    public class DIContainer
    {
        private static readonly Dictionary<Type, object> RegisteredModules = new Dictionary<Type, object>();

        public static void SetModule<TInterface, TModule>()
        {
            SetModule(typeof(TInterface), typeof(TModule));
        }

        private static void SetModule(Type interfaceType, Type moduleType)
        {
            if (!interfaceType.IsAssignableFrom(moduleType))
            {
                throw new Exception("Wrong module type");
            }

            var firstConstructor = moduleType.GetConstructors()[0];
            object module = null;

            if (!firstConstructor.GetParameters().Any())
            {
                module = firstConstructor.Invoke(null);
            }
            else
            {
                var constructorParameters = firstConstructor.GetParameters();

                var moduleDependencies = new List<object>();
                foreach (var parameter in constructorParameters)
                {
                    var dependency = GetModule(parameter.ParameterType);
                    moduleDependencies.Add(dependency);
                }

                module = firstConstructor.Invoke(moduleDependencies.ToArray());
            }

            RegisteredModules.Add(interfaceType, module);
        }

        public static T GetModule<T>()
        {
            return (T)GetModule(typeof(T));
        }

        private static object GetModule(Type interfaceType)
        {
            if (RegisteredModules.ContainsKey(interfaceType))
            {
                return RegisteredModules[interfaceType];
            }
            throw new Exception("Module not register");
        }
    }
}
