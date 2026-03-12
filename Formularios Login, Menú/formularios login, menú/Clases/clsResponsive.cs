using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRAMADE.Formularios_Login__Menú
{
    internal class clsResponsive
    {
    }

    public class ResponsiveFormManager
    {
        private struct ControlInfo
        {
            public float X, Y, Width, Height;
            public float FontSize;
        }

        private readonly Form _form;
        private readonly Dictionary<Control, ControlInfo> _originalLayout = new Dictionary<Control, ControlInfo>();
        private SizeF _originalFormSize;
        private bool _initialized = false;

        public ResponsiveFormManager(Form form)
        {
            _form = form;
        }

        /// <summary>
        /// Llama esto en el evento Load del formulario, DESPUÉS de InitializeComponent().
        /// </summary>
        public void Initialize()
        {
            _originalFormSize = new SizeF(_form.ClientSize.Width, _form.ClientSize.Height);
            SaveLayout(_form.Controls);
            _initialized = true;
        }

        /// <summary>
        /// Llama esto en el evento Resize o SizeChanged del formulario.
        /// </summary>
        public void AdjustLayout()
        {
            if (!_initialized) return;

            float scaleX = _form.ClientSize.Width / _originalFormSize.Width;
            float scaleY = _form.ClientSize.Height / _originalFormSize.Height;

            ApplyLayout(_form.Controls, scaleX, scaleY);
        }

        // ── Privados ────────────────────────────────────────────────

        private void SaveLayout(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                _originalLayout[ctrl] = new ControlInfo
                {
                    X = ctrl.Location.X,
                    Y = ctrl.Location.Y,
                    Width = ctrl.Size.Width,
                    Height = ctrl.Size.Height,
                    FontSize = ctrl.Font.Size
                };

                if (ctrl.HasChildren)
                    SaveLayout(ctrl.Controls);
            }
        }

        private void ApplyLayout(Control.ControlCollection controls, float scaleX, float scaleY)
        {
            foreach (Control ctrl in controls)
            {
                if (!_originalLayout.TryGetValue(ctrl, out ControlInfo info)) continue;

                ctrl.SuspendLayout();

                ctrl.Location = new Point(
                    (int)(info.X * scaleX),
                    (int)(info.Y * scaleY));

                ctrl.Size = new Size(
                    (int)(info.Width * scaleX),
                    (int)(info.Height * scaleY));

                // Escala la fuente proporcionalmente (usa el menor de los dos factores)
                float fontScale = Math.Min(scaleX, scaleY);
                float newSize = Math.Max(5f, info.FontSize * fontScale); // mínimo 5pt
                ctrl.Font = new Font(ctrl.Font.FontFamily, newSize, ctrl.Font.Style);

                ctrl.ResumeLayout();

                if (ctrl.HasChildren)
                    ApplyLayout(ctrl.Controls, scaleX, scaleY);
            }
        }
    }
}
