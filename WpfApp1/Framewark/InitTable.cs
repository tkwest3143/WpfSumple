using System;
using System.Collections.Generic;
using System.Text;

namespace Framewark
{
    /// <summary>
    /// 初めてアプリケーションを利用する際にテーブルを作成します。
    /// </summary>
    class InitTable
    {
        private string userinfo = "create table userinfo(" +
            "realname varchar(20)," +
            "username varchar(20), " +
            "Birthday int," +
            "Sex varchar(10)" +
            ");";
        public InitTable()
        {

        }
    }
}
