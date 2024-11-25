﻿using System.Runtime.Serialization;

namespace GestaoPedidosBlazorApp.Client.Models
{
    public enum AddressType
    {
        [EnumMember(Value = "Entrega")]
        Delivery,

        [EnumMember(Value = "Cobrança")]
        Billing,

        [EnumMember(Value = "Ambos")]
        Both
    }
}
