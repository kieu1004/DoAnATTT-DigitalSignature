﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Signature.DTO
{
    internal class KeyDTO
    {
        private int _sig_id;
        public int sig_id
        {
            get { return _sig_id; }
            set { _sig_id = value; }
        }

        private string _private_key;
        public string private_key
        {
            get { return _private_key; }
            set { _private_key = value; }
        }

        private int _public_key;
        public int public_key
        {
            get { return _public_key; }
            set { _public_key = value; }
        }

        private int _n;
        public int n
        {
            get { return _n; }
            set { _n = value; }
        }

        private int _user_id;
        public int user_id
        {
            get { return _user_id; }
            set { _user_id = value; }
        }


        public KeyDTO(int sig_id_, string private_key_, int public_key_, int n_, int user_id_)
        {
            this.sig_id = sig_id_;
            this.private_key = private_key_;
            this.public_key = public_key_;
            this.n = n_;
            this.user_id = user_id_;
        }

        public KeyDTO()
        {
            this.sig_id = 0;
            this.private_key = "";
            this.public_key = 0;
            this.n = 0;
            this.user_id = 0;
        }
    }
}