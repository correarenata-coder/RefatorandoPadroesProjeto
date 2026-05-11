using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo05_Refatorado
{
    public class LoginViaFaceNoteFake : LoginViaFaceNote
    {
        public LoginViaFaceNoteFake(ServicoFaceNoteLogin servicoFaceNote) : base(servicoFaceNote)
        {
        }


        public bool FoiChamado { get; private set; }

        public string? UsuarioRecebido { get; private set; }

        public override RespostaLogin Autenticar(string idUsuario)
        {
            FoiChamado = true;
            UsuarioRecebido = idUsuario;

            return new RespostaLogin("login com sucesso", true);
        }
    }

}
