﻿namespace Madness_In_Space.Forms
{
	partial class Room_Placement_Window
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.Vessel_Name_Indicator = new System.Windows.Forms.Label();
			this.Available_Rooms_Label = new System.Windows.Forms.Label();
			this.Available_Room_List = new System.Windows.Forms.ListView();
			this.Room_properties_Group = new System.Windows.Forms.GroupBox();
			this.Room_Z_Dimension = new System.Windows.Forms.TrackBar();
			this.Room_Y_Dimension = new System.Windows.Forms.TrackBar();
			this.Room_X_Dimension = new System.Windows.Forms.TrackBar();
			this.Room_placement_group = new System.Windows.Forms.GroupBox();
			this.Vessel_Z_Position = new System.Windows.Forms.TrackBar();
			this.Vessel_Y_Position = new System.Windows.Forms.TrackBar();
			this.Vessel_X_Position = new System.Windows.Forms.TrackBar();
			this.X_plane_position_grid = new System.Windows.Forms.Panel();
			this.Y_plane_position_grid = new System.Windows.Forms.Panel();
			this.Y_plane_position_grid_image = new System.Windows.Forms.PictureBox();
			this.Room_Type_Description = new System.Windows.Forms.Panel();
			this.Vessel_Type_Description = new System.Windows.Forms.Label();
			this.Vessel_Space_3D_Position = new System.Windows.Forms.Panel();
			this.vesseltypehere = new System.Windows.Forms.Label();
			this.Room_Budget_Label = new System.Windows.Forms.Label();
			this.Chosen_Room_List = new System.Windows.Forms.ListView();
			this.Chosen_Rooms_Label = new System.Windows.Forms.Label();
			this.Add_Room_Button = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.Room_Budget_Indicator = new System.Windows.Forms.Label();
			this.Vessel_Name_Label = new System.Windows.Forms.Label();
			this.Vessel_Type_Label = new System.Windows.Forms.Label();
			this.Room_Type_Description_Label = new System.Windows.Forms.Label();
			this.Room_Description_Box = new System.Windows.Forms.GroupBox();
			this.Room_properties_Group.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Room_Z_Dimension)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Room_Y_Dimension)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Room_X_Dimension)).BeginInit();
			this.Room_placement_group.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Vessel_Z_Position)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Vessel_Y_Position)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Vessel_X_Position)).BeginInit();
			this.Y_plane_position_grid.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Y_plane_position_grid_image)).BeginInit();
			this.Room_Type_Description.SuspendLayout();
			this.Room_Description_Box.SuspendLayout();
			this.SuspendLayout();
			// 
			// Vessel_Name_Indicator
			// 
			this.Vessel_Name_Indicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Vessel_Name_Indicator.Location = new System.Drawing.Point(180, 27);
			this.Vessel_Name_Indicator.Name = "Vessel_Name_Indicator";
			this.Vessel_Name_Indicator.Size = new System.Drawing.Size(289, 37);
			this.Vessel_Name_Indicator.TabIndex = 0;
			this.Vessel_Name_Indicator.Text = "vesselnamehere";
			this.Vessel_Name_Indicator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Available_Rooms_Label
			// 
			this.Available_Rooms_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Available_Rooms_Label.Location = new System.Drawing.Point(53, 82);
			this.Available_Rooms_Label.Name = "Available_Rooms_Label";
			this.Available_Rooms_Label.Size = new System.Drawing.Size(121, 59);
			this.Available_Rooms_Label.TabIndex = 1;
			this.Available_Rooms_Label.Text = "Available Rooms";
			this.Available_Rooms_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Available_Room_List
			// 
			this.Available_Room_List.Location = new System.Drawing.Point(53, 155);
			this.Available_Room_List.Name = "Available_Room_List";
			this.Available_Room_List.Size = new System.Drawing.Size(121, 363);
			this.Available_Room_List.TabIndex = 2;
			this.Available_Room_List.UseCompatibleStateImageBehavior = false;
			this.Available_Room_List.View = System.Windows.Forms.View.List;
			this.Available_Room_List.SelectedIndexChanged += new System.EventHandler(this.Available_Room_ListSelectedIndexChanged);
			// 
			// Room_properties_Group
			// 
			this.Room_properties_Group.Controls.Add(this.Room_Z_Dimension);
			this.Room_properties_Group.Controls.Add(this.Room_Y_Dimension);
			this.Room_properties_Group.Controls.Add(this.Room_X_Dimension);
			this.Room_properties_Group.Location = new System.Drawing.Point(219, 155);
			this.Room_properties_Group.Name = "Room_properties_Group";
			this.Room_properties_Group.Size = new System.Drawing.Size(200, 170);
			this.Room_properties_Group.TabIndex = 3;
			this.Room_properties_Group.TabStop = false;
			this.Room_properties_Group.Text = "Room_properties_Group";
			// 
			// Room_Z_Dimension
			// 
			this.Room_Z_Dimension.Location = new System.Drawing.Point(46, 121);
			this.Room_Z_Dimension.Name = "Room_Z_Dimension";
			this.Room_Z_Dimension.Size = new System.Drawing.Size(104, 45);
			this.Room_Z_Dimension.TabIndex = 2;
			this.Room_Z_Dimension.Scroll += new System.EventHandler(this.Room_Z_DimensionScroll);
			// 
			// Room_Y_Dimension
			// 
			this.Room_Y_Dimension.Location = new System.Drawing.Point(46, 70);
			this.Room_Y_Dimension.Name = "Room_Y_Dimension";
			this.Room_Y_Dimension.Size = new System.Drawing.Size(104, 45);
			this.Room_Y_Dimension.TabIndex = 1;
			this.Room_Y_Dimension.Scroll += new System.EventHandler(this.Room_Y_DimensionScroll);
			// 
			// Room_X_Dimension
			// 
			this.Room_X_Dimension.Location = new System.Drawing.Point(46, 19);
			this.Room_X_Dimension.Name = "Room_X_Dimension";
			this.Room_X_Dimension.Size = new System.Drawing.Size(104, 45);
			this.Room_X_Dimension.TabIndex = 0;
			this.Room_X_Dimension.Scroll += new System.EventHandler(this.Room_X_DimensionScroll);
			// 
			// Room_placement_group
			// 
			this.Room_placement_group.Controls.Add(this.Vessel_Z_Position);
			this.Room_placement_group.Controls.Add(this.Vessel_Y_Position);
			this.Room_placement_group.Controls.Add(this.Vessel_X_Position);
			this.Room_placement_group.Location = new System.Drawing.Point(219, 331);
			this.Room_placement_group.Name = "Room_placement_group";
			this.Room_placement_group.Size = new System.Drawing.Size(200, 187);
			this.Room_placement_group.TabIndex = 4;
			this.Room_placement_group.TabStop = false;
			this.Room_placement_group.Text = "Room_placement_group";
			// 
			// Vessel_Z_Position
			// 
			this.Vessel_Z_Position.Location = new System.Drawing.Point(46, 136);
			this.Vessel_Z_Position.Name = "Vessel_Z_Position";
			this.Vessel_Z_Position.Size = new System.Drawing.Size(104, 45);
			this.Vessel_Z_Position.TabIndex = 3;
			this.Vessel_Z_Position.Scroll += new System.EventHandler(this.Vessel_Z_PositionScroll);
			// 
			// Vessel_Y_Position
			// 
			this.Vessel_Y_Position.Location = new System.Drawing.Point(46, 85);
			this.Vessel_Y_Position.Name = "Vessel_Y_Position";
			this.Vessel_Y_Position.Size = new System.Drawing.Size(104, 45);
			this.Vessel_Y_Position.TabIndex = 2;
			this.Vessel_Y_Position.Scroll += new System.EventHandler(this.Vessel_Y_PositionScroll);
			// 
			// Vessel_X_Position
			// 
			this.Vessel_X_Position.Location = new System.Drawing.Point(46, 34);
			this.Vessel_X_Position.Name = "Vessel_X_Position";
			this.Vessel_X_Position.Size = new System.Drawing.Size(104, 45);
			this.Vessel_X_Position.TabIndex = 0;
			this.Vessel_X_Position.Scroll += new System.EventHandler(this.Vessel_X_PositionScroll);
			// 
			// X_plane_position_grid
			// 
			this.X_plane_position_grid.Location = new System.Drawing.Point(512, 370);
			this.X_plane_position_grid.Name = "X_plane_position_grid";
			this.X_plane_position_grid.Size = new System.Drawing.Size(280, 148);
			this.X_plane_position_grid.TabIndex = 5;
			// 
			// Y_plane_position_grid
			// 
			this.Y_plane_position_grid.Controls.Add(this.Y_plane_position_grid_image);
			this.Y_plane_position_grid.Location = new System.Drawing.Point(219, 539);
			this.Y_plane_position_grid.Name = "Y_plane_position_grid";
			this.Y_plane_position_grid.Size = new System.Drawing.Size(280, 148);
			this.Y_plane_position_grid.TabIndex = 6;
			// 
			// Y_plane_position_grid_image
			// 
			this.Y_plane_position_grid_image.Location = new System.Drawing.Point(3, 3);
			this.Y_plane_position_grid_image.Name = "Y_plane_position_grid_image";
			this.Y_plane_position_grid_image.Size = new System.Drawing.Size(274, 142);
			this.Y_plane_position_grid_image.TabIndex = 0;
			this.Y_plane_position_grid_image.TabStop = false;
			// 
			// Room_Type_Description
			// 
			this.Room_Type_Description.Controls.Add(this.Vessel_Type_Description);
			this.Room_Type_Description.Location = new System.Drawing.Point(512, 177);
			this.Room_Type_Description.Name = "Room_Type_Description";
			this.Room_Type_Description.Size = new System.Drawing.Size(280, 148);
			this.Room_Type_Description.TabIndex = 6;
			// 
			// Vessel_Type_Description
			// 
			this.Vessel_Type_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Vessel_Type_Description.Location = new System.Drawing.Point(4, 4);
			this.Vessel_Type_Description.Name = "Vessel_Type_Description";
			this.Vessel_Type_Description.Size = new System.Drawing.Size(273, 140);
			this.Vessel_Type_Description.TabIndex = 0;
			// 
			// Vessel_Space_3D_Position
			// 
			this.Vessel_Space_3D_Position.Location = new System.Drawing.Point(512, 539);
			this.Vessel_Space_3D_Position.Name = "Vessel_Space_3D_Position";
			this.Vessel_Space_3D_Position.Size = new System.Drawing.Size(280, 148);
			this.Vessel_Space_3D_Position.TabIndex = 7;
			// 
			// vesseltypehere
			// 
			this.vesseltypehere.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.vesseltypehere.Location = new System.Drawing.Point(636, 27);
			this.vesseltypehere.Name = "vesseltypehere";
			this.vesseltypehere.Size = new System.Drawing.Size(289, 37);
			this.vesseltypehere.TabIndex = 8;
			this.vesseltypehere.Text = "vesseltypehere";
			this.vesseltypehere.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Room_Budget_Label
			// 
			this.Room_Budget_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Room_Budget_Label.Location = new System.Drawing.Point(220, 82);
			this.Room_Budget_Label.Name = "Room_Budget_Label";
			this.Room_Budget_Label.Size = new System.Drawing.Size(149, 34);
			this.Room_Budget_Label.TabIndex = 9;
			this.Room_Budget_Label.Text = "Room Budget:";
			this.Room_Budget_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Chosen_Room_List
			// 
			this.Chosen_Room_List.Location = new System.Drawing.Point(838, 155);
			this.Chosen_Room_List.Name = "Chosen_Room_List";
			this.Chosen_Room_List.Size = new System.Drawing.Size(121, 543);
			this.Chosen_Room_List.TabIndex = 11;
			this.Chosen_Room_List.UseCompatibleStateImageBehavior = false;
			// 
			// Chosen_Rooms_Label
			// 
			this.Chosen_Rooms_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Chosen_Rooms_Label.Location = new System.Drawing.Point(838, 82);
			this.Chosen_Rooms_Label.Name = "Chosen_Rooms_Label";
			this.Chosen_Rooms_Label.Size = new System.Drawing.Size(121, 59);
			this.Chosen_Rooms_Label.TabIndex = 12;
			this.Chosen_Rooms_Label.Text = "Chosen Rooms";
			this.Chosen_Rooms_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Add_Room_Button
			// 
			this.Add_Room_Button.Location = new System.Drawing.Point(512, 693);
			this.Add_Room_Button.Name = "Add_Room_Button";
			this.Add_Room_Button.Size = new System.Drawing.Size(75, 23);
			this.Add_Room_Button.TabIndex = 13;
			this.Add_Room_Button.Text = "ADD ROOM";
			this.Add_Room_Button.UseVisualStyleBackColor = true;
			this.Add_Room_Button.Click += new System.EventHandler(this.Add_Room_ButtonClick);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(688, 693);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(104, 23);
			this.button2.TabIndex = 14;
			this.button2.Text = "DELETE ROOM";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(838, 704);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(121, 39);
			this.button3.TabIndex = 15;
			this.button3.Text = "FINISH ROOM PLACEMENT";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// Room_Budget_Indicator
			// 
			this.Room_Budget_Indicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Room_Budget_Indicator.Location = new System.Drawing.Point(375, 82);
			this.Room_Budget_Indicator.Name = "Room_Budget_Indicator";
			this.Room_Budget_Indicator.Size = new System.Drawing.Size(73, 34);
			this.Room_Budget_Indicator.TabIndex = 16;
			this.Room_Budget_Indicator.Text = "0";
			this.Room_Budget_Indicator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Vessel_Name_Label
			// 
			this.Vessel_Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Vessel_Name_Label.Location = new System.Drawing.Point(12, 27);
			this.Vessel_Name_Label.Name = "Vessel_Name_Label";
			this.Vessel_Name_Label.Size = new System.Drawing.Size(162, 37);
			this.Vessel_Name_Label.TabIndex = 17;
			this.Vessel_Name_Label.Text = "Vessel Name:";
			this.Vessel_Name_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Vessel_Type_Label
			// 
			this.Vessel_Type_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Vessel_Type_Label.Location = new System.Drawing.Point(475, 27);
			this.Vessel_Type_Label.Name = "Vessel_Type_Label";
			this.Vessel_Type_Label.Size = new System.Drawing.Size(155, 37);
			this.Vessel_Type_Label.TabIndex = 18;
			this.Vessel_Type_Label.Text = "Vessel Type:";
			this.Vessel_Type_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Room_Type_Description_Label
			// 
			this.Room_Type_Description_Label.Location = new System.Drawing.Point(6, 16);
			this.Room_Type_Description_Label.Name = "Room_Type_Description_Label";
			this.Room_Type_Description_Label.Size = new System.Drawing.Size(109, 129);
			this.Room_Type_Description_Label.TabIndex = 19;
			// 
			// Room_Description_Box
			// 
			this.Room_Description_Box.Controls.Add(this.Room_Type_Description_Label);
			this.Room_Description_Box.Location = new System.Drawing.Point(53, 539);
			this.Room_Description_Box.Name = "Room_Description_Box";
			this.Room_Description_Box.Size = new System.Drawing.Size(121, 148);
			this.Room_Description_Box.TabIndex = 19;
			this.Room_Description_Box.TabStop = false;
			// 
			// Room_Placement_Window
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1010, 755);
			this.Controls.Add(this.Room_Description_Box);
			this.Controls.Add(this.Vessel_Type_Label);
			this.Controls.Add(this.Vessel_Name_Label);
			this.Controls.Add(this.Room_Budget_Indicator);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.Add_Room_Button);
			this.Controls.Add(this.Chosen_Rooms_Label);
			this.Controls.Add(this.Chosen_Room_List);
			this.Controls.Add(this.Room_Budget_Label);
			this.Controls.Add(this.vesseltypehere);
			this.Controls.Add(this.Vessel_Space_3D_Position);
			this.Controls.Add(this.Room_Type_Description);
			this.Controls.Add(this.Y_plane_position_grid);
			this.Controls.Add(this.X_plane_position_grid);
			this.Controls.Add(this.Room_placement_group);
			this.Controls.Add(this.Room_properties_Group);
			this.Controls.Add(this.Available_Room_List);
			this.Controls.Add(this.Available_Rooms_Label);
			this.Controls.Add(this.Vessel_Name_Indicator);
			this.Name = "Room_Placement_Window";
			this.Text = "Room_Placement_Window";
			this.Room_properties_Group.ResumeLayout(false);
			this.Room_properties_Group.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Room_Z_Dimension)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Room_Y_Dimension)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Room_X_Dimension)).EndInit();
			this.Room_placement_group.ResumeLayout(false);
			this.Room_placement_group.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Vessel_Z_Position)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Vessel_Y_Position)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Vessel_X_Position)).EndInit();
			this.Y_plane_position_grid.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Y_plane_position_grid_image)).EndInit();
			this.Room_Type_Description.ResumeLayout(false);
			this.Room_Description_Box.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox Y_plane_position_grid_image;
		private System.Windows.Forms.TrackBar Vessel_Z_Position;
		private System.Windows.Forms.GroupBox Room_Description_Box;
		private System.Windows.Forms.Label Room_Type_Description_Label;
		private System.Windows.Forms.Label Vessel_Type_Description;
		private System.Windows.Forms.Label Vessel_Type_Label;
		private System.Windows.Forms.Label Vessel_Name_Label;
		private System.Windows.Forms.Label Room_Budget_Indicator;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button Add_Room_Button;
		private System.Windows.Forms.Label Chosen_Rooms_Label;
		private System.Windows.Forms.ListView Chosen_Room_List;
		private System.Windows.Forms.Label Room_Budget_Label;
		private System.Windows.Forms.Label vesseltypehere;
		private System.Windows.Forms.Panel Vessel_Space_3D_Position;
		private System.Windows.Forms.Panel Room_Type_Description;
		private System.Windows.Forms.Panel Y_plane_position_grid;
		private System.Windows.Forms.Panel X_plane_position_grid;
		private System.Windows.Forms.TrackBar Vessel_X_Position;
		private System.Windows.Forms.TrackBar Vessel_Y_Position;
		private System.Windows.Forms.GroupBox Room_placement_group;
		private System.Windows.Forms.TrackBar Room_X_Dimension;
		private System.Windows.Forms.TrackBar Room_Y_Dimension;
		private System.Windows.Forms.TrackBar Room_Z_Dimension;
		private System.Windows.Forms.GroupBox Room_properties_Group;
		private System.Windows.Forms.ListView Available_Room_List;
		private System.Windows.Forms.Label Available_Rooms_Label;
		private System.Windows.Forms.Label Vessel_Name_Indicator;
		

		

	}
}
