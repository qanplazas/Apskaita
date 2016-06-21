using Apskaita.BussinesLogicLayer.Ataskaita;
using Apskaita.Vaizdai;
using System;

namespace Apskaita.Prezenteriai.Ataskaitos
{
    class LikuciaiAtaskaitaPrezenteris
    {
        IAtaskaitaView vaizdas;
        private readonly LikuciaiBLL bll = new LikuciaiBLL();
        public LikuciaiAtaskaitaPrezenteris(IAtaskaitaView vaizdas)
        {
            this.vaizdas = vaizdas;
            
        }

        public void ikelti()
        {
            vaizdas.Padaliniai.DataSource = bll.GautiPadalinius();
            vaizdas.Saskaitos.DataSource = bll.GautiBuhSaskaitas();
        }

        public void IkeltiDuomenis(DateTime pradzia, DateTime pabaiga, int padalinysId)
        {
            vaizdas.AtaskaitaBindingSuorce.DataSource = bll.GautiAtaskaitosDuomenis(pradzia, pabaiga, padalinysId);
        }
    }
}
