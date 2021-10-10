using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestNetCore.Model
{
    public class pgUser
    {
        public int page { get; set; }
        public int pageSize { get; set; }
        public int totalPage { get; set; }
        public string totalApa { get; set; }
        public IList<ModUser> data { get; set; } = new List<ModUser>();
    }

    public class ModUser
    {
        public string username { get; set; }
        public string password { get; set; }
        public string erp_user_id { get; set; }
        public string roles_id { get; set; }
        public string organization_id { get; set; }
        public string is_tmm { get; set; }
        public string fcm_token { get; set; }
        public string nik { get; set; }
        public string full_name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string image_url { get; set; }
        public string bank_name { get; set; }
        public string bank_account { get; set; }
        public string address { get; set; }
        public string is_active { get; set; }
        public string created_by { get; set; }
        public string created_on { get; set; }
        public string update_by { get; set; }
        public string update_on { get; set; }
    }
}
