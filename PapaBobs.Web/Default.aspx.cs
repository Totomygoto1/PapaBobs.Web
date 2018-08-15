using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PapaBobs.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private bool textBoxDataIsValid()
        {
            //throw new NotImplementedException();
            int x = 0;

            if (nameTextBox.Text.Trim().Length == 0)
            {
                textBoxValidationError("name");
                x++;
                return false;
            }
            else if (nameTextBox.Text.Trim().Length == 0)
            {
                textBoxValidationError("address");
                x++;
                return false;
            }
            else if (nameTextBox.Text.Trim().Length == 0)
            {
                textBoxValidationError("zip code");
                x++;
                return false;
            }
            else if (nameTextBox.Text.Trim().Length == 0)
            {
                textBoxValidationError("phone number");
                x++;
                return false;
            }
            else
            {
                return true;
            }


        }

        protected void orderButton_Click(object sender, EventArgs e)
        {

            if(!textBoxDataIsValid())
            {
                return;
            }

            PapaBobs.DTO.OrderDTO orderDTO = new DTO.OrderDTO();

            orderDTO.OrderId = Guid.NewGuid();

            orderDTO.Size = determineSize();
            orderDTO.Crust = determineCrust();
            orderDTO.Sausage = sausageCheckBox.Checked;
            orderDTO.Pepperoni = pepperoniCheckBox.Checked;
            orderDTO.Onions = onionCheckBox.Checked;
            orderDTO.GreenPeppers = greenPepperCheckBox.Checked;
            orderDTO.Name = nameTextBox.Text;
            orderDTO.Address = addressTextBox.Text;
            orderDTO.ZipCode = zipCodeTextBox.Text;
            orderDTO.Phone = phoneTextBox.Text;
            orderDTO.PaymentType = determinePayment();
            orderDTO.TotalCost = 16.50M;

            Domain.OrderManager.CreateOrder(orderDTO);

        }

        private void textBoxValidationError(string errorType)
        {
            string errorMessage = "";
            errorMessage += string.Format("<strong>Please enter a {0}.</strong>", errorType);
            validationLabel.Text = errorMessage;
            validationLabel.Visible = true;
        }

        private PapaBobs.DTO.Enums.PaymentType determinePayment()
        {
            PapaBobs.DTO.Enums.PaymentType paymentMethod;
            if (cashRadio.Checked)
            {
                paymentMethod = DTO.Enums.PaymentType.Cash;
            }
            else
            {
                paymentMethod = DTO.Enums.PaymentType.Credit;
            }

            return paymentMethod;
        }

        private DTO.Enums.SizeType determineSize()
        {
            DTO.Enums.SizeType size;

            if(!Enum.TryParse(sizeDropDown.SelectedValue, out size))
            {
                throw new Exception("Could not determine Pizza size.");
            }

            return size;
        }

        private DTO.Enums.CrustType determineCrust()
        {
            DTO.Enums.CrustType crust;

            if (!Enum.TryParse(crustDropDown.SelectedValue, out crust))
            {
                throw new Exception("Could not determine Pizza crust.");
            }

            return crust;
        }


    }
}
