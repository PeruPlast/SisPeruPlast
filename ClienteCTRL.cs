using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAO;
namespace CTRL
{
    public class ClienteCTRL
    {
         ClienteDAO dao_cli= new ClienteDAO();

        public String RegistrarCliente(ClienteDTO dto_cli)
        {
            return dao_cli.Registrarcliente(dto_cli);
        }

        public String ModificarCliente(ClienteDTO dto_cli)
        {
            return dao_cli.ModificarCliente(dto_cli);
        }
        public DataSet mostrar_clientes()
        {
            return dao_cli.Mostrar_clientes();
        }
        public DataSet mostrarCategoriaCli()
        {
            return dao_cli.mostrarCatCli();
        }
        public DataSet muestra_Cliente(ClienteDTO dto_cli)
        {
            return dao_cli.Mostrar_cliente(dto_cli);
        }
        public DataSet mostrar_clienteXnombre(ClienteDTO dto_cli)
        {
            return dao_cli.Mostrar_clientexNombre(dto_cli);
        }
        public bool EliminarCliente(int id)
        {
            ClienteDTO dto_prod = new ClienteDTO();
            dto_prod.Id_cliente = id;
            return dao_cli.EliminarCliente(dto_prod);
        }
    }
}
