using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace DataAcessLayer.ViewModels
{
    public class AssociateViewModel
    {
        public int AssociateId { get; set; }
        [Required(ErrorMessage = "Please enter name.")]
        [MaxLength(50, ErrorMessage = "Maximum length exceeded")]
        [RegularExpression("[A-Za-z ]*", ErrorMessage = "Invalid Name ")]
        //[RegularExpression(@"/^[a-z ,.'-]+$/i",ErrorMessage ="Enter valid name.")]
        [Display(Name ="Name")]
        public string AssociateName { get; set; }
        [Required(ErrorMessage = "Please enter phone number.")]
        [DataType(DataType.PhoneNumber)]
       // [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]
        [StringLength(13, MinimumLength = 10,ErrorMessage ="Invalid number of digits.")]
        //[RegularExpression(@"^(?:\d{8}|00\d{10}|\+\d{2}\d{8})$", ErrorMessage = "Not a valid Phone number")]

        [Display(Name = "Phone")]
        public string AssociatePhone { get; set; }
        [Required(ErrorMessage = "Please enter address.")]
        [Display(Name = "Address")]
        public string AssociateAddress { get; set; } 
       // [Required(ErrorMessage = "Please select Specialization.")]
        public List<SpecializationViewModel> Specializations { get; set; }
        [Display(Name = "Specialization")]
        public string SpecializationSummary{ get; set; }
        //[Required]
        public List<int> specializationIds { get; set; }
    }
}
