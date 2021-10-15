using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMI.Custom.Gmi_Sr.Ubl2 {
    internal class UblExceptionBase : Exception {

        public UblExceptionBase() : base(message: "Error creating UBL invoice") { }

        public UblExceptionBase(string message) : base(message) { }

        public UblExceptionBase(string message, Exception innerException)
            : base(message, innerException) { }

    }
}
