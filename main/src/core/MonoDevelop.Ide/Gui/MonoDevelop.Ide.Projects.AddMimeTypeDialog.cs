// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.Ide.Projects
{
	internal partial class AddMimeTypeDialog
	{
		private global::Gtk.VBox vbox2;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.Entry entry;
		
		private global::Gtk.HBox hbox1;
		
		private global::MonoDevelop.Components.ImageView image;
		
		private global::Gtk.Label labelDesc;
		
		private global::Gtk.Button buttonCancel;
		
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			MonoDevelop.Components.Gui.Initialize (this);
			// Widget MonoDevelop.Ide.Projects.AddMimeTypeDialog
			this.Name = "MonoDevelop.Ide.Projects.AddMimeTypeDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Add File Type");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child MonoDevelop.Ide.Projects.AddMimeTypeDialog.VBox
			global::Gtk.VBox w1 = (Gtk.VBox)this.ContentArea;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			this.vbox2.BorderWidth = ((uint)(9));
			// Container child vbox2.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Enter a file extension or a mime type name:");
			this.vbox2.Add (this.label1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label1]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.entry = new global::Gtk.Entry ();
			this.entry.CanFocus = true;
			this.entry.Name = "entry";
			this.entry.IsEditable = true;
			this.entry.InvisibleChar = '●';
			this.vbox2.Add (this.entry);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.entry]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.image = new global::MonoDevelop.Components.ImageView ();
			this.image.Name = "image";
			this.image.IconId = "gtk-dialog-error";
			this.image.IconSize = ((global::Gtk.IconSize)(1));
			this.hbox1.Add (this.image);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.image]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.labelDesc = new global::Gtk.Label ();
			this.labelDesc.Name = "labelDesc";
			this.labelDesc.Xalign = 0F;
			this.hbox1.Add (this.labelDesc);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.labelDesc]));
			w5.Position = 1;
			this.vbox2.Add (this.hbox1);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox1]));
			w6.Position = 2;
			w6.Expand = false;
			w6.Fill = false;
			w1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox2]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Internal child MonoDevelop.Ide.Projects.AddMimeTypeDialog.ActionArea
			global::Gtk.HButtonBox w8 = (Gtk.HButtonBox)this.ActionArea;
			w8.Name = "dialog1_ActionArea";
			w8.Spacing = 10;
			w8.BorderWidth = ((uint)(5));
			w8.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w9 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w8 [this.buttonCancel]));
			w9.Expand = false;
			w9.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-add";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w10 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w8 [this.buttonOk]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 164;
			this.image.Hide ();
			this.Hide ();
			this.entry.Changed += new global::System.EventHandler (this.OnEntryChanged);
		}
	}
}
