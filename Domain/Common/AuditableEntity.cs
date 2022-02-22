using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    //ta klasa będzie dostarczać wiadomości kto ostatnio edytował daną encje 
    //jest to klasa bazowa z której będą dziedziczyć inne klasy gdy będziemy 
    //chcieli dodać funkcjonalność adytu
    public abstract class AuditableEntity
    {
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
