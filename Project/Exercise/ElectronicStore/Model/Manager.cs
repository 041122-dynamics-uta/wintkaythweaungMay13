﻿using System.Collections;
using System.Data;
using System.Text;
using  System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Configuration;


namespace ShopModel;

public class Manager
{ 
public int managerID { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        public bool isAdmin { get; set; }

        public Manager()
        {
            managerID = 0;
            username = "";
            password = "";
            isAdmin = true;
        }
 
  
        }    
      
    
