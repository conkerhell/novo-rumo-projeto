//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option or rebuild the Visual Studio project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Web.Application.StronglyTypedResourceProxyBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class LocalizedMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal LocalizedMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Resources.LocalizedMessages", global::System.Reflection.Assembly.Load("App_GlobalResources"));
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Este campo aceita tags HTML de edição de texto como por exemplo: p, strong, i, br.
        /// </summary>
        internal static string AllowHtml {
            get {
                return ResourceManager.GetString("AllowHtml", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Falha.
        /// </summary>
        internal static string FailedTitle {
            get {
                return ResourceManager.GetString("FailedTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Formato do arquivo invalido. Apenas os formatos {0} sao suportados..
        /// </summary>
        internal static string FileFormatInvalid {
            get {
                return ResourceManager.GetString("FileFormatInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Por favor, selecione um arquivo..
        /// </summary>
        internal static string FileRequired {
            get {
                return ResourceManager.GetString("FileRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to O tamanho do arquivo nao deve exceder {0}..
        /// </summary>
        internal static string FileSizedExceeded {
            get {
                return ResourceManager.GetString("FileSizedExceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Operacao concluida com sucesso.
        /// </summary>
        internal static string operationSucced {
            get {
                return ResourceManager.GetString("operationSucced", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Campo não é válido..
        /// </summary>
        internal static string PropertyValueInvalid {
            get {
                return ResourceManager.GetString("PropertyValueInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Campo obrigatório..
        /// </summary>
        internal static string PropertyValueRequired {
            get {
                return ResourceManager.GetString("PropertyValueRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Operação realizada com sucesso. Ver alterações {0}.
        /// </summary>
        internal static string SuccessTitle {
            get {
                return ResourceManager.GetString("SuccessTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Erro inesperado, tente novamente..
        /// </summary>
        internal static string UnexpectedError {
            get {
                return ResourceManager.GetString("UnexpectedError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ocorreu um erro inesperado durante a doação, por favor tente novamente..
        /// </summary>
        internal static string UnexpectedErrorDuringPayment {
            get {
                return ResourceManager.GetString("UnexpectedErrorDuringPayment", resourceCulture);
            }
        }
    }
}
