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
        // User::create([
        //     'name' => 'Anshad',
        //     'email' => 'marshu817@gmail.com',
        //     'password' => '123',

        // ]);

        User::factory()->count(100)->create();
    }
}
