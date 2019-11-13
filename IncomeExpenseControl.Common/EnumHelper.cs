﻿using IncomeExpenseControl.Data.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseControl.Common
{
    public class EnumHelper
    {
        public string GetEnumDescription(Enum value)
        {
            Type type = value.GetType();
            string name = Enum.GetName(type, value);
            if (name != null)
            {
                FieldInfo field = type.GetField(name);
                if (field != null)
                {
                    DescriptionAttribute attr = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
                    if (attr != null)
                    {
                        return attr.Description;
                    }
                    else
                    {
                        return name;
                    }
                }
                else
                {
                    return name;
                }
            }
            return null;
        }

        /// <summary>
        /// Int tipinden enumlar içindir. !!
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        /// 
        public List<SelectListItem> GetEnumListWithDescription(Type type)
        {
            List<SelectListItem> list = new List<SelectListItem>();

            try
            {
                foreach (var item in Enum.GetValues(type))
                {
                    list.Add(new SelectListItem() { Text = GetEnumDescription(Enum.Parse(type, item.ToString()) as Enum), Value = ((Int32)Enum.Parse(type, item.ToString())).ToString() });
                }
            }
            catch { list = new List<SelectListItem>(); }

            return list;
        }
        public List<SelectListItem> GetEnumListWithDescriptionNode(Type type)
        {
            List<SelectListItem> list = new List<SelectListItem>();

            try
            {
                foreach (var item in Enum.GetValues(type))
                {
                    list.Add(new SelectListItem() { Text = GetEnumDescription(Enum.Parse(type, item.ToString()) as Enum), Value = (Enum.Parse(type, item.ToString())).ToString() });
                }
            }
            catch { list = new List<SelectListItem>(); }

            return list;
        }
        public List<SelectListItem> GetEnumListWithDescriptionNumber(Type type)
        {
            List<SelectListItem> list = new List<SelectListItem>();

            try
            {
                foreach (var item in Enum.GetValues(type))
                {
                    list.Add(new SelectListItem() { Text = GetEnumDescription(Enum.Parse(type, item.ToString()) as Enum), Value = ((Int32)Enum.Parse(type, item.ToString())).ToString() });
                }
            }
            catch { list = new List<SelectListItem>(); }

            return list;
        }
        public object StringToEnumName<T>(string name) // Name'i string olarak gönderilen enum'ı döndürür. 
        {
            object getEnum = new object();
            try
            {
                getEnum = (T)Enum.Parse(typeof(T), name);
                // return getEnum;
            }
            catch (Exception ex)
            {
                getEnum = ex.Message;
            }
            return getEnum;

        }
        public int StringToEnumValue<T>(string name) // Name'i string olarak gönderilen enum'ın value'sunu döndürür.
        {
            int enumName = -1;
            try
            {
                byte getValue = (byte)Enum.Parse(typeof(T), name);
                enumName = getValue;
            }
            catch (Exception ex)
            {

            }
            return enumName;
        }
        public string IntToEnumName<T>(int value) // Value'su int olarak gönderilen enum'ın name'ini döndürür.
        {
            string getName = "";
            try
            {
                string getEnum = Enum.GetName(typeof(T), value);
                getName = (string)(object)getEnum;
            }
            catch (Exception ex)
            {

            }
            return getName;
        }
        public bool IsEnum<T>(object value) // Objeden gelen değerin o enum'da olup olmadığını kontrol eder.
        {
            bool getEnum = false;
            try
            {
                getEnum = Enum.IsDefined(typeof(T), value);
                // return getEnum;
            }
            catch (Exception ex)
            {

            }
            return getEnum;

        }
    }
}
