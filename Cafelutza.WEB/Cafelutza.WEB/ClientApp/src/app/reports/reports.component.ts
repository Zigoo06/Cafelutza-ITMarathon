import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Raport } from '../models/raport';
import { HttpClient } from '@angular/common/http';
import { RaportService } from '../services/raport.service';

@Component({
  selector: 'app-reports',
  templateUrl: './reports.component.html',
  styleUrls: ['./reports.component.scss'],
})
export class ReportsComponent {
  _location = new FormControl('');
  _category = new FormControl('');
  _description = new FormControl('');

  form = new FormGroup({
    Location: this._location,
    Category: this._category,
    Description: this._description,
  });

  raport = new Raport();
  imgUrl: any;
  imgData: any;

  constructor(private raportService: RaportService) {}

  onFileSelected(event: any) {
    let reader = new FileReader();
    reader.readAsDataURL(event.target.files[0]);
    reader.onload = () => {
      this.imgUrl = reader.result;
    };
  }

  onFormSubmit() {
    this.raport.category = this.form.value.Category
      ? this.form.value.Category
      : '';
    this.raport.description = this.form.value.Description
      ? this.form.value.Description
      : '';
    this.raport.location = this.form.value.Location
      ? this.form.value.Location
      : '';
    this.raport.imageURL = this.imgUrl;

    this.raportService.sendRaport(this.raport);
    this.resetForm();
  }

  resetForm() {
    this.form.reset();
    window.location.reload();
  }
}
