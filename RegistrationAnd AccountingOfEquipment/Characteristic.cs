//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RegistrationAnd_AccountingOfEquipment
{
    using System;
    using System.Collections.Generic;
    
    public partial class Characteristic
    {
        public int ID_Characteristic { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public int Device { get; set; }
    
        public virtual Device Device1 { get; set; }
    }
}