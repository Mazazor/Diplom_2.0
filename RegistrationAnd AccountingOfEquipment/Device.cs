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
    
    public partial class Device
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Device()
        {
            this.Characteristic = new HashSet<Characteristic>();
            this.RepairWork = new HashSet<RepairWork>();
            this.SoftwareInstallation = new HashSet<SoftwareInstallation>();
            this.DeviceMovement = new HashSet<DeviceMovement>();
        }
    
        public int ID_Device { get; set; }
        public string Name { get; set; }
        public string InventoryNumber { get; set; }
        public int DeviceType { get; set; }
        public int DeviceStatus { get; set; }
        public int Room { get; set; }
        public System.DateTime DateOfPurchase { get; set; }
        public string GuarantyPeriod { get; set; }
        public double Price { get; set; }
        public int ResponsibleEmployee { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Characteristic> Characteristic { get; set; }
        public virtual DeviceType DeviceType1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RepairWork> RepairWork { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SoftwareInstallation> SoftwareInstallation { get; set; }
        public virtual Room Room1 { get; set; }
        public virtual DeviceStatus DeviceStatus1 { get; set; }
        public virtual Employee Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeviceMovement> DeviceMovement { get; set; }
    }
}
