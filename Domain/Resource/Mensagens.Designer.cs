﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain.Resource {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Mensagens {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Mensagens() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Domain.Resource.Mensagens", typeof(Mensagens).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to O campo {0} é inválido..
        /// </summary>
        public static string CampoInvalido {
            get {
                return ResourceManager.GetString("CampoInvalido", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to O campo {0} é obrigatório..
        /// </summary>
        public static string CampoObrigatorio {
            get {
                return ResourceManager.GetString("CampoObrigatorio", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to O campo {0} deve possuir valores entre {1} a {2} ..
        /// </summary>
        public static string CampoRangeInválido {
            get {
                return ResourceManager.GetString("CampoRangeInválido", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to O campo {0} deve conter numeros negativos e positivos..
        /// </summary>
        public static string ListaNegativaEPositiva {
            get {
                return ResourceManager.GetString("ListaNegativaEPositiva", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to O campo {0} deve possuir valores maiores que {1}..
        /// </summary>
        public static string MaiorQue {
            get {
                return ResourceManager.GetString("MaiorQue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A lista de numeros deve conter pelo menos 1 numero {}..
        /// </summary>
        public static string NumeroNegativoPositivo {
            get {
                return ResourceManager.GetString("NumeroNegativoPositivo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pelo menos uma das informações precisa ser preenchida.
        /// </summary>
        public static string PreencherCampos {
            get {
                return ResourceManager.GetString("PreencherCampos", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Registro não encontrado..
        /// </summary>
        public static string RegistroNaoEncontrado {
            get {
                return ResourceManager.GetString("RegistroNaoEncontrado", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to O numero de vogais não condiz com o numero de censuras do texto original..
        /// </summary>
        public static string TextoCensuradoNaoCondizTextoVoagis {
            get {
                return ResourceManager.GetString("TextoCensuradoNaoCondizTextoVoagis", resourceCulture);
            }
        }
    }
}
