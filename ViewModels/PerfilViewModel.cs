using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace FlowyAPP.ViewModels
{
    public partial class PerfilViewModel : ObservableObject
    {
        [ObservableProperty]
        private int idPerfil;
        [ObservableProperty]
        private string nomePerfil;
        [ObservableProperty]
        private int nivelPerfil;
    }
}
