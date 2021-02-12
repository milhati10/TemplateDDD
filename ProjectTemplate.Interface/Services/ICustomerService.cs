using ProjectTemplate.Interface.DTO;

namespace ProjectTemplate.Interface.Services
{
    public interface ICustomerService
    {
        CustomerDTO GetCustomerByID(string ID);

        CustomerDTO Save(CustomerDTO customerDTO);

        CustomerDTO Edit(CustomerDTO customerDTO);
    }
}
