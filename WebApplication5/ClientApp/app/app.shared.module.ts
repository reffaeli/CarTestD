import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule,ReactiveFormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { FetchEmployeeComponent } from './components/fetchmember/fetchmember.component';
//import { CounterComponent } from './components/counter/counter.component';
import { createemployee } from './components/addmember/Addmember.component';

@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
       // CounterComponent,
        FetchEmployeeComponent,
        createemployee
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        ReactiveFormsModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
           // { path: 'counter', component: CounterComponent },
            { path: 'fetch-employee', component: FetchEmployeeComponent },  
            { path: 'register-employee', component: createemployee },  
            { path: 'employee/edit/:id', component: createemployee },
            { path: '**', redirectTo: 'home' }
        ])
    ],
     providers: [EmployeeService]
})
export class AppModuleShared {
}
