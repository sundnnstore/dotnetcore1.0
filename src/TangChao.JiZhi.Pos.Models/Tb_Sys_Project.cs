//-----------------------------------------------------------------------
// <copyright file=" Tb_sys_project.cs" company="xxxx Enterprises">
// * Copyright (C) 2016 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: tb_sys_project.cs
// * history : Created by T4 11/29/2016 21:08:48 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace TangChao.JiZhi.Pos.Models
{
    /// <summary>
    /// 项目信息表
    /// </summary>    
    public class Tb_sys_project
    {
        /// <summary>
        /// 
        /// </summary>
        public int ID { get; set; }
    
        /// <summary>
        /// 项目ID
        /// </summary>
        public int p_id { get; set; }
    
        /// <summary>
        /// 项目名称
        /// </summary>
        public string p_name { get; set; }
    
        /// <summary>
        /// 项目编码
        /// </summary>
        public string p_code { get; set; }
    
        /// <summary>
        /// 是否启用该条记录
        /// </summary>
        public int active { get; set; }
    
        /// <summary>
        /// 项目LOGO
        /// </summary>
        public string p_logo { get; set; }
    
        /// <summary>
        /// 记录创建时间
        /// </summary>
        public DateTime syscreated { get; set; }
    }
}
