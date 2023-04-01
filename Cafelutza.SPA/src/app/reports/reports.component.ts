import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-reports',
  templateUrl: './reports.component.html',
  styleUrls: ['./reports.component.scss'],
})
export class ReportsComponent {
  form = new FormGroup({
    Id: new FormControl(),
    Category: new FormControl(),
    Descrition: new FormControl(),
    Location: new FormControl(),
    ImageURL: new FormControl(),
  });
  imgUrl: any;
  imgData: any;
  base64Data: any;
  onFileSelected(event: any) {
    console.log(event.target.files[0]);

    let reader = new FileReader();
    reader.readAsDataURL(event.target.files[0]);
    reader.onload = (event2) => {
      console.log(reader.result);
      this.imgUrl = reader.result;
    };
  }

  postForm() {}
}
