#nullable disable
using GymProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GymProject.BL.Models.AccessModels
{
    public class SignInModel
    {
        [Required]
        [DisplayName("E-Mail")]
        [EmailAddress]
        public string  Email { get; set; }

        [Required]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$", ErrorMessage = "Minimum eight characters, at least one uppercase letter, one lowercase letter and one number")]
        public string Password { get; set; }

        [Required]
        [Compare(nameof(Password), ErrorMessage = "The password and confirmation password do not match")]
        public string PasswordConfirmed { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime Birth { get; set; }

        [Required]
        public double Height { get; set; }

        [Required]
        public double Weight { get; set; }


        private UserDetailsModel ToUserDetailsModel()
        {
            UserDetailsModel model = new UserDetailsModel();
            model.Weight = Weight;
            model.FirstName = FirstName;
            model.LastName = LastName;
            model.Birth = Birth;
            model.Height = Height;
            model.Weight = Weight;
            return model;
        }

        public UserModel ToUserModel()
        {
            UserModel user = new UserModel();
            user.IsActived = false;
            user.Email = Email;
            user.UserName = Email;
            user.Details = ToUserDetailsModel();
            return user;
        }



    }
}
