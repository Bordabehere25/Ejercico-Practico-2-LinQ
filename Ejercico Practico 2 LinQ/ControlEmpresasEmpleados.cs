using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico_Practico_2_LinQ
{
    internal class ControlEmpresasEmpleados
    {
        public List<Empresa> listaEmpresas;
        public List<Empleado> listaEmpleados;

        public ControlEmpresasEmpleados()
        {
            listaEmpresas = new List<Empresa>();
            listaEmpleados = new List<Empleado>();

            listaEmpresas.Add(new Empresa { Id = 1, Nombre = "IAlpha" });
            listaEmpresas.Add(new Empresa { Id = 2, Nombre = "Udelar" });
            listaEmpresas.Add(new Empresa { Id = 3, Nombre = "SpaceZ" });

            listaEmpleados.Add(new Empleado { Id = 1, Nombre = "Gonzalo", Cargo = "CEO", EmpresaId = 1, Salario = 3000 });
            listaEmpleados.Add(new Empleado { Id = 2, Nombre = "JuanC", Cargo = "Desarrollador", EmpresaId = 1, Salario = 2000 });
            listaEmpleados.Add(new Empleado { Id = 3, Nombre = "JuanR", Cargo = "Desarrollador", EmpresaId = 1, Salario = 1000 });
            listaEmpleados.Add(new Empleado { Id = 4, Nombre = "Daniel", Cargo = "Desarrollador", EmpresaId = 1, Salario = 2000 });
            listaEmpleados.Add(new Empleado { Id = 4, Nombre = "GonzaloT", Cargo = "CEO", EmpresaId = 2, Salario = 3000 });
            listaEmpleados.Add(new Empleado { Id = 6, Nombre = "Leonardo", Cargo = "CEO", EmpresaId = 1, Salario = 5000 });
            listaEmpleados.Add(new Empleado { Id = 1, Nombre = "Gonzalo", Cargo = "PEPITO", EmpresaId = 3, Salario = 200000 });
            listaEmpleados.Add(new Empleado { Id = 6, Nombre = "Leonardo", Cargo = "CEO", EmpresaId = 3, Salario = 150000 });

            Console.WriteLine("Prueba GIT");
        }
        /////FUNCIONES GETTERS (OBETER DATOS)

        public void getCEO(string _Cargo)
        {
            listaEmpleados.Where(x => x.Cargo == _Cargo).ToList()
                .ForEach(x => x.getDatosEMpreado());
        }

        public void getEmpleadosOrdeandos()
        {
            listaEmpleados.OrderBy(x => x.Nombre).ToList().ForEach(x => x.getDatosEMpreado());

        }

        public void getEmpleadosOrdenadosSegun()
        {
            listaEmpleados.OrderBy(x => x.Salario).ToList().ForEach(x => x.getDatosEMpreado());
        }


        public void getEmpleadoEmpresa(int empresaID)
        {
            listaEmpleados.Where(x => x.EmpresaId == empresaID).ToList().ForEach(x => x.getDatosEMpreado());
        }


        public void promedioSalario()
        {
            listaEmpleados.GroupBy(x => x.EmpresaId)
                .Select(g => new { EmpresaID = g.Key, PromedioSalario = g.Average(e => e.Salario) })
                .ToList().ForEach(g => Console.WriteLine("En la empresa {0}  el salario promedio es {1}", g.EmpresaID, g.PromedioSalario));

        }


        public void ceoEmpresa()
        {
            Console.WriteLine("La cantidad de ceos en la empresa 1 es: " + listaEmpleados.Count(x => x.EmpresaId == 1 && x.Cargo == "CEO"));


        }


        public void mayorSalario()
        {

            //int salarioMax = listaEmpleados.Max(e => e.Salario);
            //listaEmpleados.Where(x => x.Salario == salarioMax)
            //  .ToList()
            //  .ForEach(x => x.getDatosEMpreado());

            listaEmpleados.Where(x => x.Salario == listaEmpleados.Max(e => e.Salario))
            .ToList()
            .ForEach(x => x.getDatosEMpreado());


        }

        public void mayoresSueldosEmpleados()
        {
            listaEmpleados.Where(x => x.Salario > 2200)
             .ToList().ForEach(x => x.getDatosEMpreado());
        }


        public void mayorSueldoPorCargo()
        {
            listaEmpleados.GroupBy(x => x.Cargo)
                .Select(g => new { Cargo = g.Key, MayorSueldo = g.Max(e => e.Salario) })
                .ToList().ForEach(g => Console.WriteLine("En el cargo {0}  el salario maximo es {1}", g.Cargo, g.MayorSueldo));
        }
    
    
    public void mayorSueldoPorEmpresa() {

            listaEmpleados.GroupBy(x => x.EmpresaId)
                .Select(g => new { EmpresaId = g.Key, MayorSueldo = g.Max(e => e.Salario) })
                .ToList().ForEach(g => Console.WriteLine("En la empresa {0}  el salario maximo es {1}", g.EmpresaId, g.MayorSueldo));
        }

    }
}
