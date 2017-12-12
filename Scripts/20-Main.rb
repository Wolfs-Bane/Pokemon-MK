# Must be called before anything else
System.initialize

Species.compile

#b = Species.new(1)
#p b.base_exp
#p b.types
#p b.gender_rate
#p b.growth_rate
#p b.base_stats



# Commented out so you can play the map
#pbLoadScene

$Viewports = {}
# Maps, events
$Viewports["main"] = Viewport.new(0,0,Graphics.width,Graphics.height)

$Map = Map.new(2)
$Player = Player.new
npc = Character.new(1)


loop do
  begin
    Graphics.update
    Input.update
    $Player.update
    npc.update
    npc.do_random if Input.trigger?(Input::C)
    $Map.update
  rescue
    e = $!
    System.show_formatted_error(e)
  end
end