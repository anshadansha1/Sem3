<?php

namespace App\Models;

// use Illuminate\Contracts\Auth\MustVerifyEmail;
use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Foundation\Auth\User as Authenticatable;
use Illuminate\Notifications\Notifiable;

class User extends Authenticatable
{
    use HasFactory, Notifiable;

    protected $dates= ['email_verified_at'];

    // public function getEmailVerifiedAtAttribute($value){
    //     return date('d-M-Y',strtotime($value));
    // }
    public function getEmailVerifiedAtFormatedAttribute(){
        return date('d-M-Y',strtotime($this->email_verified_at));
    }
    public function getStatusTextAttribute(){
        if($this->email_verified_at != NULL)
            return "Good";
        else 
            return "Bad";
    }

    protected $appends = ['email_verified_at_formated','status_text'];

    /**
     * The attributes that are mass assignable.
     *
     * @var array<int, string>
     */
    protected $fillable = [
        'name',
        'email',
        'password',
    ];

    /**
     * The attributes that should be hidden for serialization.
     *
     * @var array<int, string>
     */
    protected $hidden = [
        'password',
        'remember_token',
    ];

    /**
     * Get the attributes that should be cast.
     *
     * @return array<string, string>
     */
    protected function casts(): array
    {
        return [
            'email_verified_at' => 'datetime',
            'password' => 'hashed',
        ];
    }
}
