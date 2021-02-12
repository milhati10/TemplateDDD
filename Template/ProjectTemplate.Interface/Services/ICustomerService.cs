using $ext_projectname$.Interface.DTO;

namespace $safeprojectname$.Services
{
    public interface ICustomerService
    {
        CustomerDTO GetCustomerByID(string ID);

        CustomerDTO Save(CustomerDTO customerDTO);

        CustomerDTO Edit(CustomerDTO customerDTO);
    }
}
