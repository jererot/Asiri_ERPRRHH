using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace common.Model.Validation
{

    public class ValPersonaMetaData
    {
        [Key]
        public long idPersona { get; set; }

        [Required]
        [StringLength(1)]
        public string tipoPersoneria { get; set; }

        [StringLength(300, ErrorMessage = "Se acepta un maximo de 300 caracteres")]
        [Display(Name = "Nombre del representante:")]
        public string nombreRepresentante { get; set; }

        [StringLength(100,ErrorMessage = "Se acepta un maximo de 100 caracteres" )]
        [MaxLength(100,ErrorMessage = "Se acepta un maximo de 100 caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de caracteres 2")]
        [DataType(DataType.Text)]
        [Display(Name = "Nombre:")]
        public string nombrePersona { get; set; }

        [StringLength(70, ErrorMessage = "Se acepta un maximo de 70 caracteres")]
        [Display(Name = "Apellido Paterno:")]
        public string apellidoPaterno { get; set; }

        [StringLength(70, ErrorMessage = "Se acepta un maximo de 70 caracteres")]
        [Display(Name = "Apellido Materno:")]
        public string apellidoMaterno { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Se acepta un maximo de 30 digitos")]
        [MinLength(1,ErrorMessage ="Se acepta como mínimo 1 caracter")]
        [Display(Name = "Número de documento*:")]
        public string numDocIdentidad { get; set; }

        [StringLength(200, ErrorMessage = "Se acepta un maximo de 200 caracteres")]
        [Display(Name = "Razon Social:")]
        public string razonSocial { get; set; }

        [Column(TypeName = "date")]
		[Display(Name="Fecha de Nacimiento:")]
        public DateTime? fecNacimiento { get; set; }

        [StringLength(100, ErrorMessage = "Solo acepta un maximo de 100 caracteres")]
        [Display(Name = "Nombre de Via:")]
        public string nombreVia { get; set; }

        [StringLength(10, ErrorMessage = "Solo acepta un maximo de 10 caracteres")]
        [Display(Name = "Numero de Via:")]
        public string numVia { get; set; }

        [StringLength(100, ErrorMessage = "Solo acepta un maximo de 100 caracteres")]
        [Display(Name = "Nombre de Zona:")]
        public string nombreZona { get; set; }

        [StringLength(120, ErrorMessage = "Solo acepta un maximo de 120 caracteres")]
        [Display(Name = "Dirección:")]
        public string direccion01 { get; set; }

        [StringLength(120, ErrorMessage = "Solo acepta un maximo de 120 caracteres")]
        [Display(Name = "Dirección Opcional:")]
        public string direccion02 { get; set; }

        [StringLength(15, ErrorMessage = "Solo acepta un maximo de 15 digitos")]
        [Display(Name = "Numero de teléfono:")]
        [DataType(DataType.PhoneNumber,ErrorMessage = "Ingrese un número correcto Ejemplo: 987654321")]
        [RegularExpression("^[0-9]{9}$",ErrorMessage = "Ingrese un número correcto Ejemplo: 987654321")]
        public string numTelefonico01 { get; set; }

        [StringLength(15, ErrorMessage = "Solo acepta un maximo de 15 digitos")]
        [Display(Name = "Numero de teléfono opcional:")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression("^[0-9]{8}$")]
        public string numTelefonico02 { get; set; }

        [StringLength(120, ErrorMessage = "Solo acepta un maximo de 120 caracteres")]
        [Display(Name = "Correo Electrónico:")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail no es valido")]
        public string email01 { get; set; }

        [StringLength(120, ErrorMessage = "Solo acepta un maximo de 120 caracteres")]
        [Display(Name = "Correo Electrónico Opcional:")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail no es valido")]
        public string email02 { get; set; }

        [StringLength(1)]
        [Display(Name = "Sexo:")]
        public string sexo { get; set; }

        [Display(Name = "Difunto:")]
        public bool difunto { get; set; }

        [Display(Name = "Fecha de Defunción:")]
        [Column(TypeName = "date")]
        public DateTime? fecDefuncion { get; set; }
        [Display(Name = "Foto:")]
        public byte[] pathFoto { get; set; }
        [Display(Name = "Activo:")]
        public bool activo { get; set; }


        [Display(Name = "Fecha de Registro:")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime fecRegistro { get; set; }
        [Display(Name = "Fecha de Modificación:")]
        public DateTime? fecModificacion { get; set; }
        [Display(Name = "Fecha de Eliminación:")]
        public DateTime? fecEliminacion { get; set; }

        [Required]
        [StringLength(128)]
        [Display(Name = "Usuario:")]
        public string idUsuario { get; set; }

        [StringLength(128)]
        [Display(Name = "Usuario Modificar:")]
        public string idUsuarioModificar { get; set; }

        [StringLength(128)]
        [Display(Name = "Usuario Eliminar:")]
        public string idUsuarioEliminar { get; set; }

        public int? idVia { get; set; }

        public int? idZona { get; set; }

        public int idTipoDocIdentidad { get; set; }

        public int? idDistrito { get; set; }

        public short? idEstadoCivil { get; set; }

        [StringLength(250)]
        [Display(Name = "Observación:")]
        public string obsvPersona { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RHUt01_empleado> RHUt01_empleado { get; set; }

        public virtual RHUt05_estadoCivil RHUt05_estadoCivil { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RHUt07_paciente> RHUt07_paciente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RHUt10_personaRedSocial> RHUt10_personaRedSocial { get; set; }

        public virtual RHUt12_tipoDocIdentidad RHUt12_tipoDocIdentidad { get; set; }

        public virtual UBIt01_distrito UBIt01_distrito { get; set; }

        public virtual UBIt04_via UBIt04_via { get; set; }

        public virtual UBIt05_zona UBIt05_zona { get; set; }
    }
}
