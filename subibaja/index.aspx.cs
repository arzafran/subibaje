﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelos;
using subibaja.ClasesBase;

namespace subibaja
{
    public partial class index : Pagina
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.VerificarLogin();
        }

    }
}