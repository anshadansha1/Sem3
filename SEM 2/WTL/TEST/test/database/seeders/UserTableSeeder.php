<?php

namespace Database\Seeders;

use App\Models\User;
use Illuminate\Database\Seeder;
use Illuminate\Database\Console\Seeds\WithoutModelEvents;

class UserTableSeeder extends Seeder
{
    /**
     * Run the database seeds.
     */
    public function run(): void
    {
        User::factory()->count(100)->create();
        
        // User::create([
        //     'name' => 'Anshad',
        //     'email' => 'marshu817@gmail.com',
        //     'dob' => '2000-04-11',
        // ]);
        // User::create([
        //     'name' => 'Nihal',
        //     'email' => 'niga123@gmail.com',
        //     'dob' => '2002-03-23',
        // ]);
        // User::create([
        //     'name' => 'Majo',
        //     'email' => 'majo123@gmail.com',
        //     'dob' => '2002-02-10',
        // ]);
    }
}
