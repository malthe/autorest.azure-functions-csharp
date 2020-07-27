// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace AppConfiguration.Models
{
    /// <summary> The User. </summary>
    public partial class User
    {
        /// <summary> Initializes a new instance of User. </summary>
        public User()
        {
        }

        /// <summary> Initializes a new instance of User. </summary>
        /// <param name="id"> . </param>
        /// <param name="username"> . </param>
        /// <param name="firstName"> . </param>
        /// <param name="lastName"> . </param>
        /// <param name="email"> . </param>
        /// <param name="password"> . </param>
        /// <param name="phone"> . </param>
        /// <param name="userStatus"> User Status. </param>
        internal User(long? id, string username, string firstName, string lastName, string email, string password, string phone, int? userStatus)
        {
            Id = id;
            Username = username;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Phone = phone;
            UserStatus = userStatus;
        }

        public long? Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        /// <summary> User Status. </summary>
        public int? UserStatus { get; set; }
    }
}
