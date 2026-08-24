// Copyright Epic Games, Inc. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Character.h"
#include "PlayerCharacter.generated.h"

class UCameraComponent;
class UInputAction;
struct FInputActionValue;

/**
 *  First person player character.
 *  Moves with WASD relative to the camera facing direction, and looks around with the mouse.
 */
UCLASS()
class APlayerCharacter : public ACharacter
{
	GENERATED_BODY()

public:

	APlayerCharacter();

protected:

	/** First person camera, mounted at eye height directly on the capsule */
	UPROPERTY(VisibleAnywhere, BlueprintReadOnly, Category = "Components", meta = (AllowPrivateAccess = "true"))
	TObjectPtr<UCameraComponent> FirstPersonCamera;

	/** Move Input Action (WASD) */
	UPROPERTY(EditAnywhere, Category = "Input")
	TObjectPtr<UInputAction> MoveAction;

	/** Look Input Action (Mouse) */
	UPROPERTY(EditAnywhere, Category = "Input")
	TObjectPtr<UInputAction> LookAction;

	/** Jump Input Action */
	UPROPERTY(EditAnywhere, Category = "Input")
	TObjectPtr<UInputAction> JumpAction;

	//~ Begin APawn Interface
	virtual void SetupPlayerInputComponent(class UInputComponent* PlayerInputComponent) override;
	//~ End APawn Interface

	/** Called for movement input */
	void Move(const FInputActionValue& Value);

	/** Called for look input */
	void Look(const FInputActionValue& Value);

public:

	/** Returns FirstPersonCamera subobject **/
	FORCEINLINE UCameraComponent* GetFirstPersonCamera() const { return FirstPersonCamera; }
};
