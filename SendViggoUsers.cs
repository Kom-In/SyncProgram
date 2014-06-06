using System;
using System.Collections.Generic;
using System.Windows.Forms;
//using Viggo_winform.develop.viggo;
using Viggo_winform.localhostStig;
namespace Viggo_winform
{
    public partial class SendViggoUsers : Form
    {
        public SendViggoUsers()
        {
            InitializeComponent();
        }
        
        private void SendUsersButtonClick(object sender, EventArgs e)
        {
            //Jeg henter ikke en tom for den ligger allerede under Service References
            var webservice = new SyncReplyClient();
            //var response = webservice.ReturnNewEmptyViggoUser(new ReturnNewEmptyViggoUser());
            
            
            //Laver en liste af ViggoUser
            var listUsrs = new List<ViggoUser>();
            //Her skal du hente alle dine bruger & relationer ud.
            //Lave et loop i brugerne
            for (int i = 0; i < 1; i++)
            {
                //Indsætter de forskellige relationer!
                var t = new List<RelationsTypesAndUser>();
                for (int k = 0; k < 2; k++)
                {
                    
                
                var r = new RelationsTypesAndUser
                    {
                        RelationsUser = new ViggoUser
                            {
                                Firstname = new FirstnameDTO
                                {
                                    Value = "RelationFornavn(" + k + ")",
                                    DataValid = true,
                                },
                                Middlename = new MiddlenameDTO
                                {
                                    Value = "RelationMiddlename(" + k + ")",
                                    DataValid = true,
                                },
                                Lastname = new LastnameDTO
                                {
                                    Value = "RelationLastname(" + k + ")",
                                    DataValid = true,
                                },
                                AccessToViggo = new AccessToViggoUserDTO
                                {
                                    Value = false,
                                    DataValid = false,
                                },
                                Birthday = new BirthdayDTO
                                {
                                    Value = DateTime.Now,
                                    DataValid = false,
                                },
                                Address = new AddressDTO
                                {
                                    Value = "",
                                    DataValid = false,
                                },
                                City = new CityDTO
                                {
                                    Value = "",
                                    DataValid = false,
                                },
                                Country = new CountryDTO
                                {
                                    Value = "",
                                    DataValid = false,
                                },
                                Cpr = new CprDTO
                                {
                                    Value = "",
                                    DataValid = false,
                                },
                                Description = new DescriptionDTO
                                {
                                    Value = "",
                                    DataValid = false,
                                },
                                Email = new EmailDTO
                                {
                                    Value = "",
                                    DataValid = false,
                                },
                                Homepage = new HomepageDTO
                                {
                                    Value = "",
                                    DataValid = false,
                                },
                                Initials = new InitialsUserDTO
                                {
                                    Value = "",
                                    DataValid = false,
                                },
                                Mobile = new MobileDTO
                                {
                                    Value = "",
                                    DataValid = false,
                                },
                                Note = new NoteDTO
                                {
                                    Value = "",
                                    DataValid = false,
                                },
                                Phone = new PhoneDTO
                                {
                                    Value = "",
                                    DataValid = false,
                                },
                                PhoneContact = new PhoneContactDTO
                                {
                                    Value = "",
                                    DataValid = false,
                                },
                                Remove = new RemoveDTO()
                                {
                                    Value = false,
                                    DataValid = false,
                                },
                                Sex = new SexDTO
                                {
                                    Value = 1,
                                    DataValid = false,
                                },
                                StudentId = new StudentIdDTO
                                {
                                    Value = null,
                                    DataValid = false,
                                },
                                StudentRoom = new StudentRoomDTO
                                {
                                    Value = "",
                                    DataValid = false,
                                },
                                SyncId = new SyncIdUserDTO
                                {
                                    Value = "31d6351c-2768-1032-b6eb-1ef5725e7f0"+k+"",
                                    DataValid = true,
                                },
                                UniCUser = new UniCUserDTO
                                {
                                    Value = "",
                                    DataValid = false,
                                },
                                Zipcode = new ZipcodeDTO
                                {
                                    Value = "",
                                    DataValid = false,
                                },
                                Timestamp = new TimestampDTO
                                {
                                    Value = DateTime.Now,
                                    DataValid = false,
                                },
                                LocalCity = new LocalCityUserDTO
                                {
                                    Value = "",
                                    DataValid = false,
                                },
                                ProtectedAddress = new ProtectedAddressUserDTO
                                {
                                    Value = false,
                                    DataValid = false,
                                },
                                ProtectedMobile = new ProtectedMobileUserDTO
                                {
                                    Value = false,
                                    DataValid = false,
                                },
                                ProtectedPhone = new ProtectedPhoneUserDTO
                                {
                                    Value = false,
                                    DataValid = false,
                                },
                                ProtectedWorkPhone = new ProtectedWorkPhoneUserDTO
                                {
                                    Value = false,
                                    DataValid = false,
                                },
                                WorkPhone = new WorkPhoneDTO
                                {
                                    Value = "",
                                    DataValid = false,
                                },
                                Relations = new ViggoRelations
                                {
                                    DataValid = false,
                                },
                                
                              
                            },
                        Name = "Far", // Hvilken relation de har!
                       UsertypeId = 5
                       
                    };
                t.Add(r);
                }
                //Indsæt data fra brugeren!
                var user = new ViggoUser
                    {
                        Firstname = new FirstnameDTO
                            {
                                Value = "Firstname(" + i + ")",
                                DataValid = true, 
                            },
                        Middlename = new MiddlenameDTO
                            {
                                Value = "Middlename(" + i + ")",
                                DataValid = true, 
                            },
                        Lastname = new LastnameDTO
                            {
                                Value = "Lastname(" + i + ")",
                                DataValid = true, 
                            },
                        AccessToViggo = new AccessToViggoUserDTO
                            {
                                Value = false,
                                DataValid = false,
                            },
                        Birthday = new BirthdayDTO
                            {
                                Value = DateTime.Now,
                                DataValid = false,
                            },
                        Address = new AddressDTO
                            {
                                Value = "",
                            DataValid = false,
                            },
                        City = new CityDTO
                            {
                                Value = "",
                                DataValid = false,
                            },
                        Country = new CountryDTO
                            {
                                Value = "",
                                DataValid = false,
                            },
                        Cpr = new CprDTO
                            {
                                Value = "",
                                DataValid = false,
                            },
                        Description = new DescriptionDTO
                            {
                                Value = "",
                                DataValid = false,
                            },
                        Email = new EmailDTO
                            {
                                Value = "",
                                DataValid = false,
                            },
                        Homepage = new HomepageDTO
                            {
                                Value = "",
                                DataValid = false,
                            },
                        Initials = new InitialsUserDTO
                            {
                                Value = "",
                                DataValid = false,
                            },
                        Mobile = new MobileDTO
                            {
                                Value = "",
                                DataValid = false,
                            },
                        Note = new NoteDTO
                        {
                            Value = "",
                            DataValid = false,
                        },
                        Phone =new PhoneDTO
                        {
                            Value = "",
                            DataValid = false,
                        },
                        PhoneContact = new PhoneContactDTO
                        {
                            Value = "",
                            DataValid = false,
                        },
                        Remove = new RemoveDTO()
                        {
                            Value = false,
                            DataValid = false,
                        },
                        Sex = new SexDTO
                        {
                            Value = 1,
                            DataValid = false,
                        },
                        StudentId = new StudentIdDTO
                        {
                            Value = null,
                            DataValid = false,
                        },
                        StudentRoom = new StudentRoomDTO
                        {
                            Value = "",
                            DataValid = false,
                        },
                        SyncId = new SyncIdUserDTO
                        {
                            Value = "S1d6351c-2768-1032-b6eb-1ef5725e7f0" + i + "",
                            DataValid = true,
                        },
                        UniCUser = new UniCUserDTO
                        {
                            Value = "",
                            DataValid = false,
                        },
                        Zipcode = new ZipcodeDTO
                        {
                            Value = "",
                            DataValid = false,
                        },
                        Timestamp = new TimestampDTO
                        {
                            Value = DateTime.Now,
                            DataValid = false,
                        },
                        LocalCity = new LocalCityUserDTO
                        {
                            Value = "",
                            DataValid = false,
                        },
                        ProtectedAddress = new ProtectedAddressUserDTO
                        {
                            Value = false,
                            DataValid = false,
                        },
                        ProtectedMobile = new ProtectedMobileUserDTO
                        {
                            Value = false,
                            DataValid = false,
                        },
                        ProtectedPhone = new ProtectedPhoneUserDTO
                        {
                            Value = false,
                            DataValid = false,
                        },
                        ProtectedWorkPhone = new ProtectedWorkPhoneUserDTO
                        {
                            Value = false,
                            DataValid = false,
                        },
                        WorkPhone = new WorkPhoneDTO
                        {
                            Value = "",
                            DataValid = false,
                        },
                        //Tilføjer Relationer til brugeren
                        Relations = new ViggoRelations
                            {
                               RelationsUsers =  t.ToArray(),
                               DataValid = true,
                            },
                    };
                listUsrs.Add(user);
            }
            //Sender til ViggoServeren!
            var s = webservice.ReceiveUsers(new ReceiveUsers
                {
                    Username = "apidemo@viggo.dk",
                    UsertypeId = 1,
                    Password = "demo",
                    ViggoUsers = listUsrs.ToArray()
                });
        }

        private void GetUserTypByUserButtonClick(object sender, EventArgs e)
        {
            var webservice = new SyncReplyClient();
            var s = webservice.GetUsertyps(new GetUsertyps
            {
                Username = "apidemo@viggo.dk",
                Password = "demo",
                All = false,
            });
        }

        private void GetAllUserTypsButtonClick(object sender, EventArgs e)
        {
            var webservice = new SyncReplyClient();
            var s = webservice.GetUsertyps(new GetUsertyps
            {
                Username = "apidemo@viggo.dk",
                Password = "demo",
                All = true,
            });
        }

        private void GetUsersButtonClick(object sender, EventArgs e)
        {
            var webservice = new SyncReplyClient();
            var s = webservice.GetUsers(new GetUsers
            {
                Username = "apidemo@viggo.dk",
                UsertypeId = 1,
                Password = "demo",
            });
        }
       
            
        

    }
}
